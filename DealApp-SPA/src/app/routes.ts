import { Routes } from "@angular/router";
import { DealsComponent } from "./deals/deals.component";
import { HomeComponent } from "./home/home.component";
import { LikesComponent } from "./likes/likes.component";
import { MessagesComponent } from "./messages/messages.component";
import { AuthGuard } from "./_guards/auth.guard";


export const appRoutes: Routes = [
    { path: '', component: HomeComponent},
    {
      path: '',
      runGuardsAndResolvers: 'always',
      canActivate: [AuthGuard],
      children: [
        { path: 'deals', component: DealsComponent},
        { path: 'messages', component: MessagesComponent},
        { path: 'likes', component: LikesComponent},
        
      ]
    },
    { path: '**', redirectTo: '', pathMatch: 'full'}
]; 