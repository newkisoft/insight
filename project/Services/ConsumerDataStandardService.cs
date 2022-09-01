using System.Linq.Expressions;
using Enums;
using FizzWare.NBuilder;
using insight.Models;

namespace insight.Services;
public class ConsumerDataStandardService : IConsumerDataStandardService
{    
    private IList<Product> _products = new List<Product>();
    

    public ConsumerDataStandardService()
    {        
          _products = Builder<Product>.CreateListOfSize(100)
            .All()
            .With(p=>p.Name = "Test")
            .TheFirst(2).With(p=>p.EffectiveFrom = DateTimeOffset.Now)
            .TheNext(2).With(p=>p.EffectiveTo = DateTimeOffset.Now.AddDays(1))
            .Build();
    }

    public int Count()
    {
        return _products.Count;      

    }

    public IEnumerable<Product> GetProducts(Effective? effective)
    {       
        Expression<Func<Product, bool>> expression = c => true;        
        var effectiveFilter = Effective.ALL;  
        if(effective.HasValue)
        {
            var  now = DateTimeOffset.Now;
            var prefix = expression.Compile();
            switch(effective){
                case Effective.CURRENT:                    
                    expression = p=> prefix(p) && p.EffectiveFrom<=now && now<=p.EffectiveTo;
                    break;
                case Effective.FUTURE:                    
                    expression = p=> prefix(p) && now>p.EffectiveFrom;
                    break;
                default:
                    break;

            }
            
        }
                   
        return _products.Where(expression.Compile());        
    }
}

