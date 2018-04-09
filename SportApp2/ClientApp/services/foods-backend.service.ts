import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Food } from '../models/food';

@Injectable()
export abstract class FoodsBackendService {
    abstract addFood(newFood: Food): Observable<string>;

    abstract getFood(id: string): Observable<Food>;

    abstract getFoods(): Observable<Food[]>;

    abstract updateFood(updatedFood: Food): Observable<string>;

    abstract deleteFood(foodId: string): Observable<string>;
}