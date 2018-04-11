import { Component, OnInit } from '@angular/core';

@Component({
    selector: 'app-upload-image',
    templateUrl: './upload-image.component.html',
    styleUrls: ['./upload-image.component.css']
})
export class UploadImageCompoment implements OnInit {
    imageUrl: string = "../assets/img/upload-arrow.png";
    fileToUpload: File = null;

    constructor() {}

    ngOnInit(): void {
        throw new Error("Method not implemented.");
    }
}