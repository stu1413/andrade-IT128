import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { TokenStorageService } from 'src/app/services/token-storage.service';

@Component({
  selector: 'app-add-post',
  templateUrl: './add-post.component.html',
  styleUrls: ['./add-post.component.css']
})
export class AddPostComponent implements OnInit {
  form: any = {
    title: null,
    body: null,
  }
  

  constructor(
    private tokenStorage: TokenStorageService,
    private http: HttpClient,
    private router: Router) {}

  ngOnInit(): void {
    if (this.tokenStorage.getToken() == 'auth-token') {
      this.router.navigate(['login']);
    }
  }

  onSubmit(): void {
    const {
      title, body
    } = this.form

    this.http.post("https://localhost:7259/api/Post/add", this.form, {headers: {'Authorization': 'Bearer ' + this.tokenStorage.getToken()}, responseType: 'text'}).subscribe(data => {
      this.tokenStorage.signOut(); 
      this.router.navigate(['']);
    })
  }

}
