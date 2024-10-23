using OpenQA.Selenium;               
using OpenQA.Selenium.Chrome;        
using TechTalk.SpecFlow;             
using FluentAssertions;              
using OpenQA.Selenium.Support.UI; 
using SeleniumExtras.WaitHelpers; 

[Binding]
public class CadastroGraduacaoSteps
{
    private IWebDriver _driver;

    [Given(@"que o usuário acessa o portal")]
    public void GivenQueOUsuarioAcessaOPortal()
    {
        _driver = new ChromeDriver();
        _driver.Manage().Window.Maximize();
        _driver.Navigate().GoToUrl("https://developer.grupoa.education/subscription/");

        WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        wait.Until(driver => ((IJavaScriptExecutor)_driver).ExecuteScript("return document.readyState").Equals("complete"));


    }

    [Given(@"o usuário escolhe a opção ""(.*)""")]
    public void GivenOUsuarioEscolheAOpcao(string opcao)
    {
        WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"app\"]/main/section/div/div[2]/button")));
        element.Click();
        _driver.FindElement(By.XPath("//*[@id=\"radix-vue-select-content-4\"]/div/div/div[3]")).Click();

    }

    [Given(@"o usuário escolhe a opção pos")]
    public void GivenOUsuarioEscolheAOpcaoPos()
    {
        WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"app\"]/main/section/div/div[2]/button")));
        element.Click();
        _driver.FindElement(By.XPath("//*[@id=\"radix-vue-select-content-4\"]/div/div/div[3]")).Click();

    }

    [Given(@"seleciona o curso desejado e avança")]
    public void GivenOUsuarioSelecionaOCursoDesejadoEAvanca()
    {

        WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"app\"]/main/section/div/div[2]/button")));
        element.Click();


        WebDriverWait wait1 = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        IWebElement element1 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[contains(@id, 'radix-vue-combobox-option-')]")));
        element1.Click();
        element.Click();

        WebDriverWait wait2 = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        IWebElement element2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"app\"]/main/section/div/div[2]/div/a/button")));
        element2.Click();
    }

    [Given(@"o portal apresenta uma tela de cadastramento")]
    public void GivenOPortalApresentaATelaDeCadastramento()
    {

        WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@data-testid='cpf-input']")));
    }

    [Given(@"o usuário preenche todos os campos")]
    public void GivenOUsuarioPreencheTodosOsCampos()
    {
       
        _driver.FindElement(By.XPath("//*[@data-testid='cpf-input']")).SendKeys("27032248934");
        _driver.FindElement(By.XPath("//*[@data-testid='name-input']")).SendKeys("João");
        _driver.FindElement(By.XPath("//*[@data-testid='surname-input']")).SendKeys("Silva");
        _driver.FindElement(By.XPath("//*[@data-testid='email-input']")).SendKeys("joao.silva@example.com");
        _driver.FindElement(By.XPath("//*[@data-testid='cellphone-input']")).SendKeys("41999376832");
        _driver.FindElement(By.XPath("//*[@data-testid='cep-input']")).SendKeys("82840270");
        _driver.FindElement(By.XPath("//*[@data-testid='address-input']")).SendKeys("Rua henr 10");
        _driver.FindElement(By.XPath("//*[@data-testid='neighborhood-input']")).SendKeys("Bairro Alto");
        _driver.FindElement(By.XPath("//*[@data-testid='city-input']")).SendKeys("Curitiba");
        _driver.FindElement(By.XPath("//*[@data-testid='state-input']")).SendKeys("PR");
        _driver.FindElement(By.XPath("//*[@data-testid='country-input']")).SendKeys("Brasil");
        _driver.FindElement(By.XPath("//*[@data-testid='next-button']")).Click();
    }

    [Given(@"é apresentada uma mensagem com o usuário e senha do candidato")]
    public void GivenEApresentadaUmaMensagemComUsuarioESenhaDoCandidato()
    {
        

        WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"app\"]/main/section/div/div[1]/h3")));
    }

    [Given(@"o usuário clica na opção ""Acessar área do Candidato""")]
    public void GivenOUsuarioClicaNaOpcaoAcessarAreaDoCandidato()
    {
        
        WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@data-testid='next-button']")));
        element.Click();
    }

    [When(@"o usuário preenche o usuário e senha e clica em ""Login""")]
    public void WhenOUsuarioPreencheUsuarioESenhaEClicaEmLogin()
    {
        WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@data-testid='username-input']")));
        element.SendKeys("candidato");

        WebDriverWait wait1 = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        IWebElement element1 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("password")));
        element1.SendKeys("subscription");

        WebDriverWait wait2 = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        IWebElement element2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@data-testid='login-button']")));
        element2.Click();
    }

    [Then(@"é apresentada a área do candidato com sucesso.")]
    public void ThenEApresentadaAAreaDoCandidatoComSucesso()
    {
             var areaCandidatoVisible = _driver.FindElement(By.XPath("//span[contains(text(), 'Área do candidato')]")).Displayed;
        areaCandidatoVisible.Should().BeTrue();
    }

    [AfterScenario]
    public void TearDown()
    {
      
        _driver.Quit();
    }
}