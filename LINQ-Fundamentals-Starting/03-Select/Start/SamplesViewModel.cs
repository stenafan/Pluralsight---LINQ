using System.Text;

namespace LINQSamples
{
  public class SamplesViewModel : ViewModelBase
  {
    #region GetAllQuery
    /// <summary>
    /// Put all products into a collection using LINQ
    /// </summary>
    public List<Product> GetAllQuery()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      list = (from prod in products select prod).ToList();

      return list;
    }
    #endregion

    #region GetAllMethod
    
    public List<Product> GetAllMethod()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      list = products.Select(prod => prod).ToList();
      

      return list;
    }
    #endregion

    #region GetSingleColumnQuery
    /// <summary>
    /// Select a single column
    /// </summary>
    public List<string> GetSingleColumnQuery()
    {
      List<Product> products = GetProducts();
      List<string> list = new();
      
      list.AddRange(from prod in products select prod.Name);
      

      return list;
    }
    #endregion

    #region GetSingleColumnMethod
    /// <summary>
    /// Select a single column
    /// </summary>
    public List<string> GetSingleColumnMethod()
    {
      List<Product> products = GetProducts();
      List<string> list = new();
     
      list.AddRange(products.Select(p => p.Name));
      

      return list;
    }
    #endregion

    #region GetSpecificColumnsQuery
    /// <summary>
    /// Select a few specific properties from products and create new Product objects
    /// </summary>
    public List<Product> GetSpecificColumnsQuery()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      // Write Query Syntax Here
      

      return list;
    }
    #endregion

    #region GetSpecificColumnsMethod
    /// <summary>
    /// Select a few specific properties from products and create new Product objects
    /// </summary>
    public List<Product> GetSpecificColumnsMethod()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      list = products.Select(p => new Product
      {
        ProductID = p.ProductID,
        Name = p.Name,
        Size = p.Size
      }).ToList();
      

      return list;
    }
    #endregion

    #region AnonymousClassQuery
    /// <summary>
    /// Create an anonymous class from selected product properties
    /// </summary>
    public string AnonymousClassQuery()
    {
      List<Product> products = GetProducts();
      StringBuilder sb = new(2048);

      // Write Query Syntax Here
      

      // Loop through anonymous class
      //foreach (var prod in list)
      //{
      //  sb.AppendLine($"Product ID: {prod.Identifier}");
      //  sb.AppendLine($"   Product Name: {prod.ProductName}");
      //  sb.AppendLine($"   Product Size: {prod.ProductSize}");
      //}

      return sb.ToString();
    }
    #endregion

    #region AnonymousClassMethod
    /// <summary>
    /// Create an anonymous class from selected product properties
    /// </summary>
    public string AnonymousClassMethod()
    {
      List<Product> products = GetProducts();
      StringBuilder sb = new(2048);

      var list = products.Select(p => new
      {
        identifierare = p.ProductID,
        namn = p.Name,
        storlek = p.Size
      }).ToList();
     

      // Loop through anonymous class
      foreach (var p in list)
      {
       sb.AppendLine($"Product ID: {p.identifierare}");
       sb.AppendLine($"   Product Name: {p.namn}");
       sb.AppendLine($"   Product Size: {p.storlek}");
      }

      return sb.ToString();
    }
    #endregion
  }
}
