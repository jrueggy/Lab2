using Lab2;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class G1StepDefinitions
    {   
        ScenarioContext ctx;
        
        public G1StepDefinitions(ScenarioContext context)
        {
            ctx = context;
        }

        [Given(@"Una cuenta del usuario con (.*) soles de saldo")]
        public void GivenUnaCuentaDelUsuarioConSolesDeSaldo(int p0)
        {
            CuentaYape cuentaUsuario = new CuentaYape(p0);
            ctx.Add("cuentaUsuario", cuentaUsuario);
        }

        [Given(@"Una cuenta del vendedor con (.*) soles de saldo")]
        public void GivenUnaCuentaDelVendedorConSolesDeSaldo(int p0)
        {
            CuentaYape cuentaVendedor = new CuentaYape(p0);
            ctx.Add("cuentaVendedor", cuentaVendedor);
        }

        [When(@"usuario compra artículo de (.*) soles de valor")]
        public void WhenUsuarioCompraArticuloDeSolesDeValor(int p0)
        {
            CuentaYape cuentaUsuario = (CuentaYape)ctx["cuentaUsuario"];
            CuentaYape cuentaVendedor = (CuentaYape)ctx["cuentaVendedor"];
            bool pago = cuentaUsuario.pagar(cuentaVendedor, p0);
            ctx.Add("pago", pago);
        }

        [Then(@"el resultado de la transaccion es True")]
        public void ThenElResultadoDeLaTransaccionEsTrue()
        {
            bool pago = (bool)ctx["pago"];
            pago.Should().BeTrue();
        }

        [Then(@"usuario tiene (.*) soles de saldo")]
        public void ThenUsuarioTieneSolesDeSaldo(int p0)
        {
            CuentaYape cuentaUsuario = (CuentaYape)ctx["cuentaUsuario"];
            int saldo = cuentaUsuario.consultaSaldo();
            saldo.Should().Be(p0);
        }

        [Then(@"vendedor tiene (.*) soles de saldo")]
        public void ThenVendedorTieneSolesDeSaldo(int p0)
        {
            CuentaYape cuentaVendedor = (CuentaYape)ctx["cuentaVendedor"];
            int saldoVendedor = cuentaVendedor.consultaSaldo();

            saldoVendedor.Should().Be(p0);
        }

        [Then(@"el resultado de la transaccion es False")]
        public void ThenElResultadoDeLaTransaccionEsFalse()
        {
            bool pago = (bool)ctx["pago"];
            pago.Should().Be(false);
        }
    }
}
