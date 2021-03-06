import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule} from '@angular/common/http';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CandidatosComponent } from './candidatos/candidatos.component';
import { VotosComponent } from './votos/votos.component';
import { CollapseModule } from 'ngx-bootstrap/collapse';
import { NavComponent } from './nav/nav.component';

@NgModule({
  declarations: [
    AppComponent,
      CandidatosComponent,
      VotosComponent,
      NavComponent
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    CollapseModule.forRoot(),
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
