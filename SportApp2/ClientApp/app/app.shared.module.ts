import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { CounterComponent } from './components/counter/counter.component';

import { ConverterComponent } from './components/converter/converter.component';
import { CallendarComponent } from './components/callendar/callendar.component';

// Foods section
import { FoodsComponent } from './components/foods/foods.component';
import { FoodsService } from './components/foods/services/foods.service';
import { FoodsBackendService } from '../services/foods-backend.service';
import { HttpFoodsBackendService } from '../services/http-foods-backend';

import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { UploadImageCompoment } from '../helpers/upload-image.component';
import { CalendarModule } from 'primeng/calendar';

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        CounterComponent,
        HomeComponent,
        ConverterComponent,
        CallendarComponent,
        UploadImageCompoment,
        FoodsComponent
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        BrowserModule,
        BrowserAnimationsModule,
        CalendarModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'foods', component: FoodsComponent },
            { path: 'converter', component: ConverterComponent },
            { path: 'callendar', component: CallendarComponent },
            { path: '**', redirectTo: 'home' }
        ])
    ],
    providers: [
        FoodsService,
        { provide: FoodsBackendService, useClass: HttpFoodsBackendService }
    ]
})
export class AppModuleShared {
}
