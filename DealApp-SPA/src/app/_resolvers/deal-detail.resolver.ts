import { Injectable } from "@angular/core";
import { ActivatedRouteSnapshot, Resolve, Router } from "@angular/router";
import { Observable, of } from "rxjs";
import { catchError } from "rxjs/operators";
import { Property } from "../_models/property";
import { AlertifyService } from "../_services/alertify.service";
import { PropertyService } from "../_services/property.service";



@Injectable()
export class DealDetailResolver implements Resolve<Property>{

 constructor(private propertyService: PropertyService,
             private router: Router,
             private alertify: AlertifyService){}

 resolve(route: ActivatedRouteSnapshot): Observable<Property>{
     return this.propertyService.getProperty(route.params['id']).pipe(
         catchError(error => {
             this.alertify.error('Problem retrieving data');
             this.router.navigate(['/deals']);
             return of(null);
         })
     );
 }
}