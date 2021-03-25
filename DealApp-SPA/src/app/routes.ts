import { Routes } from '@angular/router';
import { DealDetailComponent } from './deals/deal-detail/deal-detail.component';
import { DealListComponent } from './deals/deal-list/deal-list.component';
import { HomeComponent } from './home/home.component';
import { LikesComponent } from './likes/likes.component';
import { MessagesComponent } from './messages/messages.component';
import { AuthGuard } from './_guards/auth.guard';
import { DealDetailResolver } from './_resolvers/deal-detail.resolver';
import { DealListResolver } from './_resolvers/deal-list.resolver';


export const appRoutes: Routes = [
    { path: '', component: HomeComponent},
    {
      path: '',
      runGuardsAndResolvers: 'always',
      canActivate: [AuthGuard],
      children: [
        { path: 'deals', component: DealListComponent, resolve: {properties: DealListResolver }},
        { path: 'deals/:id', component: DealDetailComponent, resolve: {property: DealDetailResolver}},
        { path: 'messages', component: MessagesComponent},
        { path: 'likes', component: LikesComponent},
      ]
    },
    { path: '**', redirectTo: '', pathMatch: 'full'}
];
