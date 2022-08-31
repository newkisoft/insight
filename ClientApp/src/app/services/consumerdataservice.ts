import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";

@Injectable()
export class ConsumerDataService {
    /**
     *
     */
    constructor(private http: HttpClient) {
        
    }

    public GetAll()
    {        
        var headers = new HttpHeaders({"x-v":'1'});
        return this.http.get("/api/products/",{headers});
    }


}