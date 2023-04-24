import { Component } from '@angular/core';
import { Post } from 'src/app/models/post.model';
import { HttpClient } from '@angular/common/http';
import { TokenStorageService } from 'src/app/services/token-storage.service';

@Component({
  selector: 'app-list-posts',
  templateUrl: './list-posts.component.html',
  styleUrls: ['./list-posts.component.css']
})
export class ListPostsComponent {
  posts?: Post[] = [];

  constructor(
    private http: HttpClient, 
    private tokenStorage: TokenStorageService) { } 

  ngOnInit(): void {
    this.tokenStorage.signOut();
    this.initData();
  }

  initData(): void {
    this.http.get<Post[]>('https://localhost:7259/api/post').subscribe({
      next: (data: Post[]) => {
        this.posts = data;
        console.log(this.posts);
      }
    })
  }

}
