using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class G1StepDefinitions
    {   
        ScenarioContext ctx;
        
        public class G1StepDefinitions(ScenarioContext context)
        {
            ctx = context;
        }

        [Given(@"Una cuenta del usuario con (.*) soles de saldo")]
        public void GivenUnaCuentaDelUsuarioConSolesDeSaldo(int p0)
        {
            throw new PendingStepException();
        }

        [Given(@"Una cuenta del vendedor con (.*) soles de saldo")]
        public void GivenUnaCuentaDelVendedorConSolesDeSaldo(int p0)
        {
            throw new PendingStepException();
        }

        [When(@"usuario compra artículo de (.*) soles de valor")]
        public void WhenUsuarioCompraArticuloDeSolesDeValor(int p0)
        {
            throw new PendingStepException();
        }

        [Then(@"el resultado de la transaccion es True")]
        public void ThenElResultadoDeLaTransaccionEsTrue()
        {
            throw new PendingStepException();
        }

        [Then(@"usuario tiene (.*) soles de saldo")]
        public void ThenUsuarioTieneSolesDeSaldo(int p0)
        {
            throw new PendingStepException();
        }

        [Then(@"vendedor tiene (.*) soles de saldo")]
        public void ThenVendedorTieneSolesDeSaldo(int p0)
        {
            throw new PendingStepException();
        }

        [Then(@"el resultado de la transaccion es False")]
        public void ThenElResultadoDeLaTransaccionEsFalse()
        {
            throw new PendingStepException();
        }

        [When(@"usuario consulta su saldo")]
        public void UsuarioConsultaSuSaldo()
        {
            CuentaYape usuario =  (CuentaYape)ctx["clase"];
            int saldo = usuario.consultaSaldo();
            ctx.Add("resultadoSaldo", saldo);
        }

        [Then(@"usuario recibe su saldo de (.*) soles")]
        public void UsuarioRecibeSuSaldoDeSoles(int p0)
        {
            int sald = (int)ctx["resultadoSaldo"];
            sald.Should().Be(p0)
        }
    }
}
