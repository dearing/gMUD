import 'package:angular/angular.dart';

import 'src/todo_list/todo_list_component.dart';
import 'src/generated/mud.pb.dart';
import 'src/generated/mud.pbenum.dart';
import 'src/generated/mud.pbgrpc.dart';
import 'src/generated/mud.pbjson.dart';
// AngularDart info: https://webdev.dartlang.org/angular
// Components info: https://webdev.dartlang.org/components

@Component(
  selector: 'my-app',
  styleUrls: ['app_component.css'],
  templateUrl: 'app_component.html',
  directives: [TodoListComponent],
)
class AppComponent {
  // Nothing here yet. All logic is in TodoListComponent.
}
