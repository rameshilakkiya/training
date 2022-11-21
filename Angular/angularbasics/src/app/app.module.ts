import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DatatypesComponent } from './datatypes/datatypes.component';
import { EmployeeComponent } from './components/employee/employee.component';
import { CustomerComponent } from './components/customer/customer.component';
import { DatabindingComponent } from './components/databinding/databinding.component';
import {FormsModule} from '@angular/forms';
import { SimpleinterestComponent } from './components/simpleinterest/simpleinterest.component';
import { SimplecalculatorComponent } from './components/simplecalculator/simplecalculator.component';
import { NgswitchComponent } from './components/ngswitch/ngswitch.component';
import { StyledemoComponent } from './components/styledemo/styledemo.component';
import { ClassdemoComponent } from './components/classdemo/classdemo.component';
import { FormdemoComponent } from './components/formdemo/formdemo.component';
import { EmployeetemplatedemoComponent } from './components/employeetemplatedemo/employeetemplatedemo.component';
import { CoronaComponent } from './components/corona/corona.component';
import { TodosComponent } from './components/todos/todos.component';
import {HttpClientModule} from '@angular/common/http';
import { PostsComponent } from './components/posts/posts.component';
import { ParentComponent } from './components/parent/parent.component';
import { ChildComponent } from './components/child/child.component';
import { CompaniesComponent } from './components/companies/companies.component';
import { CompanyComponent } from './components/company/company.component';
import { ReactiveFormComponent } from './components/reactive-form/reactive-form.component';
import { ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    AppComponent,
    DatatypesComponent,
    EmployeeComponent,
    CustomerComponent,
    DatabindingComponent,
    SimpleinterestComponent,
    SimplecalculatorComponent,
    NgswitchComponent,
    StyledemoComponent,
    ClassdemoComponent,
    FormdemoComponent,
    EmployeetemplatedemoComponent,
    CoronaComponent,
    TodosComponent,
    PostsComponent,
    ParentComponent,
    ChildComponent,
    CompaniesComponent,
    CompanyComponent,
    ReactiveFormComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    ReactiveFormsModule
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
