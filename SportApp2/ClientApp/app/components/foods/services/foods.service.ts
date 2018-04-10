import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/map';
import { Food } from '../../../../models/food';
import { FoodsBackendService } from '../../../../services/foods-backend.service';

@Injectable()
export class FoodsService {
    constructor(private foodsBackendService: FoodsBackendService) { }

    addFood(newFood: Food): Observable<string> {
        return this.foodsBackendService.addFood(newFood);
    }

    getFood(id: string): Observable<Food> {
        return this.foodsBackendService.getFood(id);
    }

    getFoods(): Observable<Food[]> {
        return this.foodsBackendService.getFoods();
    }

    updateFood(updatedFood: Food): Observable<string> {
        return this.foodsBackendService.updateFood(updatedFood);
    }

    deleteFood(foodId: string): Observable<string> {
        return this.foodsBackendService.deleteFood(foodId);
    }
}


