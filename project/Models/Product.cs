using Enums;

namespace insight.Models;

public class Product
{
    public string ProductId { get; set; }= string.Empty;	//ASCIIString	mandatory	A data holder specific unique identifier for this product. This identifier must be unique to a product but does not otherwise need to adhere to ID permanence guidelines.
    public DateTimeOffset EffectiveFrom { get; set; } //DateTimeString	optional	The date and time from which this product is effective (ie. is available for origination). Used to enable the articulation of products to the regime before they are available for customers to originate
    public DateTimeOffset EffectiveTo { get; set; } //DateTimeString	optional	The date and time at which this product will be retired and will no longer be offered. Used to enable the managed deprecation of products
    public DateTimeOffset LastUpdated { get; set; }   //DateTimeString	mandatory	The last date and time that the information for this product was changed (or the creation date for the product if it has never been altered)
    public ProductCategory ProductCategory { get; set; }    //BankingProductCategory	mandatory	The category to which a product or account belongs. See here for more details
    public string Name { get; set; } = string.Empty; //string	mandatory	The display name of the product
    public string Description { get; set; } = string.Empty;//string	mandatory	A description of the product
    public string Brand { get; set; }= string.Empty;   //string	mandatory	A label of the brand for the product. Able to be used for filtering. For data holders with single brands this value is still required
    public string BrandName { get; set; } = string.Empty;  //string	optional	An optional display name of the brand
    public string ApplicationUri { get; set; } = string.Empty; //URIString	optional	A link to an application web page where this product can be applied for.
    public bool IsTailored { get; set; }    //Boolean	mandatory	Indicates whether the product is specifically tailored to a circumstance. In this case fees and prices are significantly negotiated depending on context. While all products are open to a degree of tailoring this flag indicates that tailoring is expected and thus that the provision of specific fees and rates is not applicable
    public List<AdditionalUri> AdditionalInformation { get; set; } = new List<AdditionalUri>();
    public List<AdditionalUri> AdditionalTermsUris { get; set; } = new List<AdditionalUri>();
    public List<AdditionalUri> AdditionalEligibilityUris { get; set; } = new List<AdditionalUri>();
    public List<AdditionalUri> AdditionalFeesAndPricingUris { get; set; } = new List<AdditionalUri>();
    public List<AdditionalUri> AdditionalBundleUris { get; set; } = new List<AdditionalUri>();

}