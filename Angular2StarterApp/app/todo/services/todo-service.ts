import {Injectable, OnInit} from 'angular2/core';
import {Router} from 'angular2/router';
import {Http, Headers} from 'angular2/http';
import {TodoModel} from './todo-model';

@Injectable()
export class TodoService{
    todos: Array<TodoModel> = new Array<TodoModel>();
    isEmpty: boolean = false;
    
    constructor(private _router: Router, private _http: Http){
    }
    
    getTodos(){
        return this._http.get('/api/Todos')
            .map(res =>
            {
                this.checkForMoreTodos(res.json());
                return res.json();
            });
    }
    
    addTodo(todo: TodoModel){
        
        let headers = new Headers();
        headers.append('Content-Type', 'application/json');

        return this._http.post('/api/Todos', JSON.stringify(todo), { headers: headers })
            .subscribe(() =>
            {
                this._router.navigate(["Todos"]);
            });
    }
    
    completeTodo(todo: TodoModel){
        
        todo.status = "completed";
        
        let headers = new Headers();
        headers.append('Content-Type', 'application/json');

        return this._http.put('/api/Todos', JSON.stringify(todo), { headers: headers })
            .subscribe(() =>
            {
                return this.getTodos();
            });
    }
    
    private checkForMoreTodos(todos: Array<TodoModel>){
        var allCompleted = true;
        todos.forEach(item =>{
            if(item.status != 'completed'){
                allCompleted = false;
            }
        });
        
        this.isEmpty = allCompleted;
    }
}