using CafeteriaAromaGrao;

Pedido pedido = new Pedido();

double total = pedido.CalcularTotal(10, 5);

Console.WriteLine($"Total: R${total}");

double totalComDesconto = pedido.AplicarDesconto(total);

Console.WriteLine($"Total com desconto: R${totalComDesconto}");

Console.WriteLine($"Status: {pedido.StatusPedido(totalComDesconto)}");