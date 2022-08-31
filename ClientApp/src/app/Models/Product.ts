
export class Product
{
     ProductId :string = "";
     EffectiveFrom :Date | undefined;
     EffectiveTo :Date | undefined;
     LastUpdated :Date | undefined;
     ProductCategory:string = "";
     Name:string = "";
     Description:string = "";
     Brand :string = "";
     BrandName:string = "";
     ApplicationUri:string = "";
     IsTailored:boolean = false;
     AdditionalInformation :Array<AdditionalUri> = new Array<AdditionalUri>();
     AdditionalTermsUris :Array<AdditionalUri> = new Array<AdditionalUri>();
     AdditionalEligibilityUris :Array<AdditionalUri> = new Array<AdditionalUri>();
     AdditionalFeesAndPricingUris :Array<AdditionalUri> = new Array<AdditionalUri>();
     AdditionalBundleUris :Array<AdditionalUri> = new Array<AdditionalUri>();

}