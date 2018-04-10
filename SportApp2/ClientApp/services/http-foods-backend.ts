import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { Food } from '../models/food';
import { FoodsBackendService } from './foods-backend.service';
import { Http, RequestOptions, Headers, Response } from '@angular/http';

@Injectable()
export class HttpFoodsBackendService extends FoodsBackendService {

    // url-s of the locations od the controllers methods
    private addFoodUrl: string = "api/food/addfood";
    private getFoodUrl: string = "api/food/getfood?foodId=";
    private getFoodsUrl: string = "api/food/getfoods";
    private updateFoodUrl: string = "api/food/updatefood";
    private deleteFoodUrl: string = "api/food/deletefood?foodId=";

    private jsonContentOptions: RequestOptions;
    constructor(private http: Http) {
        super();

        let headerJson: Headers = new Headers({
            'Content-Type': 'application/json',
        });

        // options of the request
        this.jsonContentOptions = new RequestOptions({ headers: headerJson })
    }

    // methods asking controllers about data
    addFood(newFood: Food): Observable<string> {
        return this.http.post(this.addFoodUrl, JSON.stringify(newFood), this.jsonContentOptions).
            map(response => response.json() as string);
    }
    getFood(id: string): Observable<Food> {
        return this.http.get(this.getFoodUrl + id, this.jsonContentOptions).map(response => response.json());
    }
    getFoods(): Observable<Food[]> {
        return this.http.get(this.getFoodsUrl, this.jsonContentOptions).map(response => response.json());
    }
    updateFood(updatedFood: Food): Observable<string> {
        return this.http.post(this.updateFoodUrl, JSON.stringify(updatedFood), this.jsonContentOptions).
            map(response => response.json() as string);
    }
    deleteFood(foodId: string): Observable<string> {
        return this.http.get(this.deleteFoodUrl + foodId, this.jsonContentOptions)
            .map(response => response.json());
    }
}
