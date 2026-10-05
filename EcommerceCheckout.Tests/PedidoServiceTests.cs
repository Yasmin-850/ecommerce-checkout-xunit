using EcommerceCheckout.App;
using Xunit;

namespace EcommerceCheckout.Tests;

public class PedidoServiceTests
{
    [Fact]
    public void GerarCodigoRastreio_DeveRetornarCodigoFormatado()
    {
        var service = new PedidoService();

        var resultado = service.GerarCodigoRastreio("sudeste", 42);

        Assert.Equal("SUDESTE-0042", resultado);
    }

    [Fact]
    public void CalcularPontosFidelidade_DeveRetornar30Pontos()
    {
        var service = new PedidoService();

        var resultado = service.CalcularPontosFidelidade(150);

        Assert.Equal(30, resultado);
    }

    [Fact]
    public void TemDireitoAFreteGratis_ClienteVIP_DeveRetornarTrue()
    {
        var service = new PedidoService();

        var resultado = service.TemDireitoAFreteGratis(150, true);

        Assert.True(resultado);
    }

    [Fact]
    public void TemDireitoAFreteGratis_ClienteNaoVIP_DeveRetornarFalse()
    {
        var service = new PedidoService();

        var resultado = service.TemDireitoAFreteGratis(150, false);

        Assert.False(resultado);
    }
}