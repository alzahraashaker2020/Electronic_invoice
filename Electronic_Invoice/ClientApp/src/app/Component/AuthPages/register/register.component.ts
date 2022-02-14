import { THIS_EXPR } from '@angular/compiler/src/output/output_ast';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { activityTypes_VM } from '../../../Models/BasicData/activityTypes_VM';
import { AddressValidations_VM } from '../../../Models/BasicData/addressValidation_VM';
import { countries_VM } from '../../../Models/BasicData/countries_VM';
import { RegisteredDate_VM } from '../../../Models/BasicData/RegisteredDate_VM';
import { Response_VM } from '../../../Models/Shared/Response_VM';
import { RegisterService } from '../../../Services/IssureServices/register.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  Response: Response_VM = new Response_VM();
  RegisteredDate_VM: RegisteredDate_VM;
  activityTypes: activityTypes_VM[];
  countries: countries_VM[];
  addressValidation: AddressValidations_VM[];
  invalidRegister: Boolean = false;
  buttonSubmit: Boolean = false;
  errorMsg: string;
  eMsg: string;
  registerForm = new FormGroup({
    firstName: new FormControl(null, [
      Validators.required,
      Validators.minLength(3),
      Validators.maxLength(30),
    ]),
    lastName: new FormControl(null, [
      Validators.required,
      Validators.minLength(3),
      Validators.maxLength(30),
    ]),
    activity: new FormControl(null, null),
    email: new FormControl(null, [Validators.required, Validators.email]),
    password: new FormControl(null, [
      Validators.required,
      Validators.minLength(8),
    ]),
    confirmPassword: new FormControl(null, [Validators.required]),
  });

  constructor(private router: Router, private services:RegisterService) { }

  ngOnInit() {
    this.services.GetRegisterdData().subscribe(
      (result: any) => {
        console.log("result", result)
        this.Response = result;
        console.log("result", this.Response);
        this.RegisteredDate_VM = this.Response.data;
        this.activityTypes = this.Response.data.activityTypes_VM;
        this.countries = this.Response.data.countries_VM;
        this.addressValidation = this.Response.data.addressValidation;
        console.log("this.activityTypes",this.activityTypes)
        console.log("this.RegisteredDate_VM", this.RegisteredDate_VM);
        console.log("addressValidation", this.addressValidation);
      //  for (var i = 0; i < this.RegisteredDate_VM.activityTypes_VM.length; i++)
      //  {
      //    this.activityTypes.push({ id: this.RegisteredDate_VM.activityTypes_VM[i].id, code: this.RegisteredDate_VM.activityTypes_VM[i].code, adescription: this.RegisteredDate_VM.activityTypes_VM[i].adescription })
      //  }
        
      }
    );
  }
  get firstName() {
    return this.registerForm.get('firstName');
  }
  get lastName() {
    return this.registerForm.get('lastName');
  }
  get email() {
    return this.registerForm.get('email');
  }
  get password() {
    return this.registerForm.get('password');
  }
  get confirmPassword() {
    return this.registerForm.get('confirmPassword');
  }
  get supplier() {
    return this.registerForm.get('activity');
  }
}
