import { Component, type OnInit } from "@angular/core"
import { RouterModule } from "@angular/router";

@Component({
    selector: "app-sidebar",
    imports: [RouterModule],
    templateUrl: "./sidebar.component.html",
    styleUrls: ["./sidebar.component.css"]
})
export class SidebarComponent implements OnInit {
  // Component implementation
  ngOnInit(): void {}
}
