import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Food } from '../../../models/food';
import { FoodsService } from '../../components/foods/services/foods.service';

@Component({
    templateUrl: './foods.component.html'
})

export class FoodsComponent implements OnInit {

    constructor(
        private foodsService: FoodsService,
        private router: Router
    ) { };

    foods: Array<Food> = new Array<Food>();
    pageTitle: string = "List of products";
    tempInfo: string = "Loading";

    ngOnInit(): void {
        this.downloadFoods();
    }

    downloadFoods(): void {
        this.foodsService.getFoods().subscribe(
            foodsFromDb => {
                if (foodsFromDb.length == 0) {
                    this.tempInfo = "No records found.";
                }
                else {
                    this.foods = foodsFromDb
                }
            },
            error => { console.log("Error: ", error)}
        );
    }

    getFood(id: string): void {
        this.router.navigate(['./foods/food-details', id]);
    }

    updateFood(id: string): void {
        this.router.navigate(['./foods/food-update']);
    }

    deleteFood(id: string): void {
        this.foodsService.deleteFood(id).subscribe(
            onSuccess => {
                console.log(onSuccess);
                this.foods.splice(this.foods.findIndex(f => f.id == id), 1);
            },
            onError => console.log(onError)
        );
    }
}

