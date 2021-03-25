import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { NgxGalleryAnimation, NgxGalleryImage, NgxGalleryOptions } from '@kolkov/ngx-gallery';
import { from } from 'rxjs';
import { Property } from 'src/app/_models/property';
import { AlertifyService } from 'src/app/_services/alertify.service';
import { PropertyService } from 'src/app/_services/property.service';

@Component({
  selector: 'app-deal-detail',
  templateUrl: './deal-detail.component.html',
  styleUrls: ['./deal-detail.component.scss']
})
export class DealDetailComponent implements OnInit {
  property: Property;

  galleryOptions: NgxGalleryOptions[];
  galleryImages: NgxGalleryImage[];

  constructor(private propertyService: PropertyService,
              private alertify: AlertifyService,
              private route: ActivatedRoute ) { }

  ngOnInit() {
    this.route.data.subscribe(data => {
      this.property = data['property'];
    });

    this.galleryOptions = [
      {
        width: '1100px',
        height: '400px',
        thumbnailsColumns: 4,
        imageAnimation: NgxGalleryAnimation.Slide
      },
      // max-width 800
      {
        breakpoint: 800,
        width: '100%',
        height: '600px',
        imagePercent: 80,
        thumbnailsPercent: 20,
        thumbnailsMargin: 20,
        thumbnailMargin: 20
      },
      // max-width 400
      {
        breakpoint: 400,
        preview: false
      }
    ];

     this.galleryOptions = [{
       width: '1110px',
       height: '500px',
       imagePercent: 100,
       thumbnailsColumns: 4,
       imageAnimation: NgxGalleryAnimation.Slide,
       preview: false
     }];
     this.galleryImages = this.getImages();
  }

   getImages(){
     const imageUrls = [];
     for (const photo of this.property.photos) {
       imageUrls.push({
         small: photo.url,
         medium: photo.url,
         big: photo.url,
         description: photo.description
       });
     }
     return imageUrls;
   }

  // loadUser(){
  //   this.propertyService.getProperty(+this.route.snapshot.params['id']).subscribe((property: Property) => {
  //     this.property = property;
  //   }, error => {
  //     this.alertify.error(error);
  //   });
  // }

}
