namespace insight.Models;

public class Data
{
    public List<Product> Products{get;set;} = new List<Product>();
    public Link Links{get;set;} = new Link();
    public Meta Meta{get;set;} = new Meta();
}