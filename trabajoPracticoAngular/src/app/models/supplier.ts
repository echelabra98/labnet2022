export class Supplier{
    SupplierID?: number;
    CompanyName: string;
    ContactName: string | undefined;
    ContactTitle: string | undefined;
    Address: string | undefined;
    City: string | undefined;

    constructor(CompanyName: string) {
        this.CompanyName = CompanyName;
    }
}