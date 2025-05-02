using System.ComponentModel.DataAnnotations.Schema;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string QuantityPerUnit { get; set; }
    [Column(TypeName = "decimal(18,4)")]
    public decimal UnitPrice { get; set; }
    public short UnitsInStock { get; set; }
    public bool OutOfStock = false;
    public short UnitsOnOrder { get; set; }
    public short ReorderLevel { get; set; }
    public bool IsBelowReorderLevel = false;
    public bool Discontinued { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }

    public void Calculation(Product product)
    {
        if (UnitsInStock <= 0)
        {
            product.OutOfStock = true;
        }
        else
        {
            product.OutOfStock = false;
        }

        if (ReorderLevel >= UnitsOnOrder)
        {
            product.IsBelowReorderLevel = false;
        }
        else
        {
            product.IsBelowReorderLevel = true;
        }
    }
}
