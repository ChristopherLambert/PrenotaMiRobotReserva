using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PrenotiRobot.Services
{
	public class RobotClass
    {
        public IWebDriver driver;
        public bool isRunning = false;
        public bool isLogin = false;
        public readonly string urlPrenoti = "https://prenotami.esteri.it/Services";
        public readonly string urlBooking671 = "https://prenotami.esteri.it/Services/Booking/671";
        public readonly string chromeDriverPath = @"C:\Program Files\Google\Chrome\Application\";

        #region Event
        public event EventHandler StateRunningChanged;
        public bool Running
        {
            get { return isRunning; }
            set
            {
                isRunning = value;
                OnStateChanged();
            }
        }

        protected virtual void OnStateChanged()
        {
            StateRunningChanged?.Invoke(this, EventArgs.Empty);
        }
        #endregion

        #region Method
        public async Task StartRobot()
        {
            this.OpenBrowser();
        }
		private void OpenBrowser()
		{
            try
            {
                // Inicializar o navegador Chrome
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("--start-maximized"); // Opcional: Iniciar o Chrome maximizado

                driver = new ChromeDriver(chromeDriverPath, options);

                // Navegar para uma URL
                string url = urlPrenoti; // Substitua pela URL que deseja abrir
                driver.Navigate().GoToUrl(url);
                this.Running = true;
                this.CycleRunning();
              
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                this.Running = false;
                // Fechar o navegador
                driver.Quit();
            }
        }

        public void CycleRunning()
        {
            try
            {
                while (this.isRunning)
                {
                    if (!this.isLogin)
                    {
                        Thread.Sleep(10000);
                        this.LoginPrenoti();
                    }

                    Thread.Sleep(5000);
                    this.ReservaPassPrenoi();
                    Thread.Sleep(2000);
                    this.GoBackScreeReserva();
                }
            }
            catch {}
        }

        public void LoginPrenoti()
        {
            if (!this.Running)
                return;

            // Classe que você deseja verificar LOGIN
            string targetClass = "login";

            // Encontre todos os elementos com a classe especificada
            IReadOnlyCollection<IWebElement> elementsWithClass = driver.FindElements(By.ClassName(targetClass));

            if (elementsWithClass.Count > 0)
            {
                Console.WriteLine($"A classe '{targetClass}' foi encontrada na página.");

                // LOGIN INPUT
                string inputId = "login-email";
                IWebElement inputElement = driver.FindElement(By.Id(inputId));
                string textoParaDigitar = "christopherwhb@gmail.com";
                inputElement.SendKeys(textoParaDigitar);

                // PASS INPUT
                string inputIdpass = "login-password";
                IWebElement inputElementpass = driver.FindElement(By.Id(inputIdpass));
                string textoParaDigitarpass = "Sunrise2512*";
                inputElementpass.SendKeys(textoParaDigitarpass);

                // LOGAR
                IWebElement buttonElement = driver.FindElement(By.ClassName("g-recaptcha"));
                // Clique no botão
                buttonElement.Click();

                this.isLogin = true;
            }
        }

        public void ReservaPassPrenoi()
        {
            if (!this.Running && !this.isLogin)
                return;

            try
            {
                // Texto visível no botão que você deseja clicar
                string buttonText = "Reservar";
                // Encontre o botão pelo texto visível
                IWebElement buttonElement = driver.FindElement(By.XPath($"//button[contains(text(), '{buttonText}')]"));
                if (buttonElement != null)
                    buttonElement.Click();
                  
            }
            catch (NoSuchElementException)
            {
                // Trate a exceção aqui, por exemplo, informando que o botão não foi encontrado
                Console.WriteLine("O botão não foi encontrado na página.");
            }
            catch (ElementClickInterceptedException)
            {
                // Trate a exceção aqui, por exemplo, informando que o botão não foi encontrado
                Console.WriteLine("O botão não foi encontrado na página (Sobreposição).");
            }
        }

        public void GoBackScreeReserva()
        {
            if (!this.Running && !this.isLogin)
                return;

            try
            {
                // Texto visível no botão que você deseja clicar
                string buttonText = "ok";
                // Encontre o botão pelo texto visível
                IWebElement buttonElement = driver.FindElement(By.XPath($"//button[contains(text(), '{buttonText}')]"));
                if (buttonElement != null)
                    buttonElement.Click();
                else
                {
                    Thread.Sleep(4000);
                    if (driver.Url == this.urlBooking671)
                    {
                        Console.WriteLine("Reserva Encontrada.");
                        Console.WriteLine("Você está na URL desejada.");
                        this.isRunning = false;
                    }
                }
            }
            catch (NoSuchElementException)
            {
                // Trate a exceção aqui, por exemplo, informando que o botão não foi encontrado
                Console.WriteLine("O botão não foi encontrado na página.");
            }
            catch (ElementClickInterceptedException)
            {
                // Trate a exceção aqui, por exemplo, informando que o botão não foi encontrado
                Console.WriteLine("O botão não foi encontrado na página (Sobreposição).");
            }
        }
        #endregion
    }
}
