import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { HistoricoDataComponent } from './historico-data/historico-data.component';
import { ConfiguracaoProvider } from '../provider/ConfiguracaoProvider';
import { HistoricoService } from '../service/historico-service';
import { FuncaoService } from '../service/funcao-service';


@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        HomeComponent,
        HistoricoDataComponent
    ],
    imports: [
        BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
        HttpClientModule,
        FormsModule,
        RouterModule.forRoot([
            { path: '', component: HomeComponent, pathMatch: 'full' },
            { path: 'historico-data', component: HistoricoDataComponent },
        ])
    ],
    providers: [ConfiguracaoProvider, HistoricoService, FuncaoService],
    bootstrap: [AppComponent]
})
export class AppModule { }
