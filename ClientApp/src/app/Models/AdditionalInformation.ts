export class AdditionalInformation {
    overviewUri: string = "";
    termsUri: string = "";
    eligibilityUri: string = "";
    esAndPricingUri: string = "";
    bundleUri: string = "";
    AdditionalOverviewUris: Array<AdditionalUri> = new Array<AdditionalUri>();
    AdditionalEligibilityUris: Array<AdditionalUri> = new Array<AdditionalUri>();
    AdditionalFeesAndPricingUris: Array<AdditionalUri> = new Array<AdditionalUri>();
    AdditionalBundleUris: Array<AdditionalUri> = new Array<AdditionalUri>();
    CardArt: CardArt = new CardArt();
}