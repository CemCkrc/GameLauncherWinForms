using GameLauncher.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncher
{
    enum Languages
    {
        EN,
        TR
    }

    enum GameEvents
    {
        READY,
        FAILED,
        DOWNLOADING_GAME,
        DOWNLOADING_UPDATE
    }

    public partial class Form1 : Form
    {
        private bool isFirstImage = false;

        private Languages currentLanguage = Languages.EN;

        private string[,] textList =
           {
            {
            "Play",
            "Update Failed",
            "Downloading Game",
            "Downloading Update",
            "Exit Launcher",
            "Error checking for game updates:",
            "Error installing game files:",
            "Error downloading game files:",
            "Ready",
            "Failed",
            "Please Wait",
            "Error changing language:",
            "Update Logs",
            "Game Title"
            },
            {
            "Oyna",
            "Guncelleme Basarisiz",
            "Oyun Indiriliyor",
            "Guncelleme Indiriliyor",
            "Cikis Yap",
            "Oyun guncelleme kontrolu basarisiz:",
            "Oyun yukleme basarisiz:",
            "Oyun indirme basarisiz:",
            "Hazir",
            "Hata",
            "Lutfen Bekleyin",
            "Dil degistirmede hata:",
            "Guncellestirme Notlari",
            "Oyun Basligi"
            }
        };

        private string rootPath;
        private string versionFile;
        private string gameZip;
        private string gameExe;

        private string _updateText;

        private GameEvents _status;
        internal GameEvents Status
        {
            get => _status;
            set
            {
                _status = value;

                updateLogText.Text = textList[(int)currentLanguage, 12];
                gameTitle.Text = textList[(int)currentLanguage, 13];

                switch (_status)
                {
                    case GameEvents.READY:
                        progressBar.Value = 0;
                        updateBox.Text = _updateText;
                        eventLabel.Text = textList[(int)currentLanguage, 8];
                        playButton.Text = textList[(int)currentLanguage, 0];
                        playButton.Enabled = true;
                        break;
                    case GameEvents.FAILED:
                        eventLabel.Text = textList[(int)currentLanguage, 9];
                        playButton.Text = textList[(int)currentLanguage, 10];
                        playButton.Enabled = false;
                        break;
                    case GameEvents.DOWNLOADING_GAME:
                        eventLabel.Text = textList[(int)currentLanguage, 2];
                        playButton.Text = textList[(int)currentLanguage, 10];
                        playButton.Enabled = false;
                        break;
                    case GameEvents.DOWNLOADING_UPDATE:
                        eventLabel.Text = textList[(int)currentLanguage, 3];
                        playButton.Text = textList[(int)currentLanguage, 10];
                        playButton.Enabled = false;
                        break;
                    default:
                        break;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();

            pictureTimer.Enabled = true;
            pictureTimer.Tick += Tick;

            playButton.MouseEnter += OnMouseEnterStartButton;
            playButton.MouseLeave += OnMouseLeaveStartButton;

            exitGameButton.MouseEnter += OnMouseEnterExitButton;
            exitGameButton.MouseLeave += OnMouseLeaveExitButton;


            rootPath = Directory.GetCurrentDirectory();
            versionFile = System.IO.Path.Combine(rootPath, "version.txt");
            gameZip = System.IO.Path.Combine(rootPath, "ExampleGame.zip");
            gameExe = System.IO.Path.Combine(rootPath, "ExampleGame", "ExampleGame.exe");

            progressBar.Text = "";

            ReadLanguage();
            CheckForUpdates();
        }

        private void OnMouseEnterStartButton(object sender, EventArgs e)
        {
            if (playButton.Enabled)
                playButton.BackColor = Color.Bisque;
        }
        private void OnMouseLeaveStartButton(object sender, EventArgs e)
        {
            if (playButton.Enabled)
                playButton.BackColor = Color.BurlyWood;
        }

        private void OnMouseEnterExitButton(object sender, EventArgs e)
        {
            exitGameButton.BackColor = Color.Bisque;
        }
        private void OnMouseLeaveExitButton(object sender, EventArgs e)
        {
            exitGameButton.BackColor = Color.BurlyWood;
        }

        private void SetLanguage()
        {
            Status = _status;
            exitGameButton.Text = textList[(int)currentLanguage, 4];
        }

        private void WriteLanguage()
        {
            StreamWriter sr = null;

            try
            {
                sr = new StreamWriter(Path.Combine(rootPath, "config.cfg"));

                switch (currentLanguage)
                {
                    case Languages.EN:
                        sr.Write("en");
                        break;
                    case Languages.TR:
                        sr.Write("tr");
                        break;
                    default:
                        break;
                }

                sr.Close();
            }
            catch (Exception ex)
            {
                Status = GameEvents.FAILED;
                MessageBox.Show($"{textList[(int)currentLanguage, 11]} {ex}");
            }
        }

        private void turkishButton_Click(object sender, EventArgs e)
        {
            currentLanguage = Languages.TR;
            SetLanguage();
            WriteLanguage();
        }

        private void englishButton_Click(object sender, EventArgs e)
        {
            currentLanguage = Languages.EN;
            SetLanguage();
            WriteLanguage();
        }

        private async Task CreateLanguageFileAsync()
        {
            string defaultLanguage = "en";
            using StreamWriter file = new(Path.Combine(rootPath, "config.cfg"));

            await file.WriteLineAsync(defaultLanguage);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(gameExe) && Status == GameEvents.READY)
            {
                ProcessStartInfo startInfo = new ProcessStartInfo(gameExe);
                startInfo.WorkingDirectory = Path.Combine(rootPath, "ExampleGame");
                Process.Start(startInfo);

                Close();
            }
            else if (Status == GameEvents.FAILED)
            {
                CheckForUpdates();
            }
        }
        private void CheckForUpdates()
        {
            if (File.Exists(versionFile))
            {
                Version localVersion = new Version(File.ReadAllText(versionFile));
                versionLabel.Text = localVersion.ToString();

                try
                {
                    WebClient webClient = new WebClient();
                    webClient.UseDefaultCredentials = true;
                    webClient.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
                    Version onlineVersion = new Version(webClient.DownloadString("versionKey"));
                    _updateText = webClient.DownloadString("updateLink");

                    if (onlineVersion.IsDifferentVersion(localVersion))
                    {
                        InstallGameFiles(true, onlineVersion);
                    }
                    else
                    {
                        Status = GameEvents.READY;
                    }
                }
                catch (Exception ex)
                {
                    Status = GameEvents.FAILED;
                    MessageBox.Show($"{textList[(int)currentLanguage, 5]} {ex}");
                }
            }
            else
            {
                InstallGameFiles(false, Version.zero);
            }
        }

        private void InstallGameFiles(bool isUpdate, Version _onlineVersion)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.UseDefaultCredentials = true;
                webClient.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
                if (isUpdate)
                {
                    Status = GameEvents.DOWNLOADING_UPDATE;
                }
                else
                {
                    Status = GameEvents.DOWNLOADING_GAME;
                    _onlineVersion = new Version(webClient.DownloadString("versionLink"));
                }
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCallbackBar);
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadGameCompletedCallback);
                webClient.DownloadFileAsync(new Uri("gameLink"), gameZip, _onlineVersion);
            }
            catch (Exception ex)
            {
                Status = GameEvents.FAILED;
                MessageBox.Show($"{textList[(int)currentLanguage, 6]} {ex}");
            }
        }

        private void DownloadProgressCallbackBar(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;

            string received = string.Format("{0:0,0}", e.BytesReceived);
            string total = string.Format("{0:0,0}", e.TotalBytesToReceive);

            progressBar.Text = $"{received} / {total}";
        }

        private void DownloadGameCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                string onlineVersion = ((Version)e.UserState).ToString();
                ZipFile.ExtractToDirectory(gameZip, rootPath, true);
                File.Delete(gameZip);
                File.WriteAllText(versionFile, onlineVersion);

                versionLabel.Text = onlineVersion;
                Status = GameEvents.READY;
            }
            catch (Exception ex)
            {
                Status = GameEvents.FAILED;
                MessageBox.Show($"{textList[(int)currentLanguage, 7]} {ex}");
            }
        }

        private void ReadLanguage()
        {
            String lang = "";
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(Path.Combine(rootPath, "config.cfg"));

                lang = sr.ReadLine();

                sr.Close();

            }
            catch (Exception)
            {
                _ = CreateLanguageFileAsync();

                currentLanguage = Languages.EN;
                SetLanguage();

                return;
            }

            switch (lang)
            {
                case "en":
                    currentLanguage = Languages.EN;
                    break;
                case "tr":
                    currentLanguage = Languages.TR;
                    break;
                default:
                    currentLanguage = Languages.EN;
                    break;
            }

            SetLanguage();
        }

        private void exitGameButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void Tick(object sender, EventArgs e)
        {
            if (isFirstImage)
            {
                isFirstImage = false;

                animatedPicture_0.Visible = false;
                animatedPicture_1.Visible = true;
            }
            else
            {
                isFirstImage = true;

                animatedPicture_0.Visible = true;
                animatedPicture_1.Visible = false;
            }
        }
    }

    struct Version
    {
        internal static Version zero = new Version(0, 0, 0);

        private short major;
        private short minor;
        private short subMinor;

        internal Version(short _major, short _minor, short _subMinor)
        {
            major = _major;
            minor = _minor;
            subMinor = _subMinor;
        }

        internal Version(string _version)
        {
            string[] _versionStrings = _version.Split('.');

            if (_versionStrings.Length != 3)
            {
                major = 0;
                minor = 0;
                subMinor = 0;
                return;
            }

            major = short.Parse(_versionStrings[0]);
            minor = short.Parse(_versionStrings[1]);
            subMinor = short.Parse(_versionStrings[2]);
        }

        internal bool IsDifferentVersion(Version _otherVersion)
        {
            if (major != _otherVersion.major)
            {
                return true;
            }
            else
            {
                if (minor != _otherVersion.minor)
                {
                    return true;
                }
                else
                {
                    if (subMinor != _otherVersion.subMinor)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public override string ToString()
        {
            return $"{major}.{minor}.{subMinor}";
        }
    }
}
