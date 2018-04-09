import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Food } from '../models/food';
import { FoodsBackendService } from './foods-backend.service';
import { Http, RequestOptions, Headers, Response } from '@angular/http';

@Injectable()
export class HttpFoodsBackendService extends FoodsBackendService {

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

        this.jsonContentOptions = new RequestOptions({ headers: headerJson })
    }

    addFood(newFood: Food): Observable<string> {
        throw new Error("Method not implemented.");
    }
    getFood(id: string): Observable<Food> {
        throw new Error("Method not implemented.");
    }
    getFoods(): Observable<Food[]> {
        throw new Error("Method not implemented.");
    }
    updateFood(updatedFood: Food): Observable<string> {
        throw new Error("Method not implemented.");
    }
    deleteFood(foodId: string): Observable<string> {
        throw new Error("Method not implemented.");
    }
}
