using Lab2;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class G2StepDefinitions
    {
        ScenarioContext ctx;

        G2StepDefinitions(ScenarioContext ctx)
        {
            this.ctx = ctx;
        }

        [Given(@"Una cuenta de usuario con (.*) soles de saldo")]
        public void GivenUnaCuentaDelUsuarioConSolesDeSaldo(int p0)
        {
            CuentaYape cuenta1 = new CuentaYape(p0);
            ctx.Add("cuenta1", cuenta1);
        }

        [When(@"Se consulta el saldo de la cuenta")]
        public void WhenSeConsultaElSaldoDeLaCuenta()
        {
            CuentaYape cuenta1 = (CuentaYape)ctx["cuenta1"];
            int saldoConsultado = cuenta1.consultaSaldo();
            ctx.Add("saldoConsultado", saldoConsultado);
        }

        [Then(@"Se muestra que el saldo de la cuenta es (.*)")]
        public void ThenSeMuestraQueElSaldoDeLaCuentaEs(int p0)
        {
            int saldoConsultado = (int)ctx["saldoConsultado"];
            saldoConsultado.Should().Be(p0);
        }
    }
}
