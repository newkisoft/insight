namespace insight.Models;

public class Data
{
    public IList<Product> Products{get;set;} = new List<Product>();
    public Link Links{get;set;} = new Link();
    public Meta Meta{get;set;} = new Meta();
}