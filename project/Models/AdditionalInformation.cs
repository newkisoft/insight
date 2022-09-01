using Enums;

namespace insight.Models;

public class AdditionalInformation
{
    public string overviewUri { get; set; } = string.Empty;
    public string termsUri { get; set; } = string.Empty;
    public string eligibilityUri { get; set; } = string.Empty;
    public string esAndPricingUri { get; set; } = string.Empty;
    public string bundleUri { get; set; } = string.Empty;
    public List<AdditionalUri> AdditionalOverviewUris { get; set; } = new List<AdditionalUri>();
    public List<AdditionalUri> AdditionalEligibilityUris { get; set; } = new List<AdditionalUri>();
    public List<AdditionalUri> AdditionalFeesAndPricingUris { get; set; } = new List<AdditionalUri>();
    public List<AdditionalUri> AdditionalBundleUris { get; set; } = new List<AdditionalUri>();

    public CardArt CardArt { get; set; } = new CardArt();
}