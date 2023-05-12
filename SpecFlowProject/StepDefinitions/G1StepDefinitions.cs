using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class G1StepDefinitions
    {
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
    }
}
