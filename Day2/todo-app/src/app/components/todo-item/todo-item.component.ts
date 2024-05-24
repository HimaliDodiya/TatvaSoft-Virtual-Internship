import { Component, Input, Output, EventEmitter } from '@angular/core';
import { Todo } from '../../models/todo.model';

@Component({
  selector: 'app-todo-item',
  templateUrl: './todo-item.component.html',
  styleUrls: ['./todo-item.component.css']
})
export class TodoItemComponent {
  @Input() todo!: Todo;
  @Output() toggle = new EventEmitter<number>();
  @Output() delete = new EventEmitter<number>();

  constructor() {}

  onToggle() {
    this.toggle.emit(this.todo.id);
  }

  onDelete() {
    this.delete.emit(this.todo.id);
  }
}
