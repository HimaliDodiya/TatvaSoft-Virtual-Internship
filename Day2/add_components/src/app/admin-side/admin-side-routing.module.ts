import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashboardComponent } from './dashboard/dashboard.component';
import { UserComponent } from './user/user.component';
import { MissionComponent } from './mission/mission.component';
import { MissionApplicationComponent } from './mission-application/mission-application.component';
import { MissionthemeComponent } from './missiontheme/missiontheme.component';
import { MissionskillComponent } from './missionskill/missionskill.component';
import { LoginComponent } from '../LoginRegister/login/login.component';
import { UpdateMissionComponent } from './mission/update-mission/update-mission.component';
import { AddMissionComponent } from './mission/add-mission/add-mission.component';
import { UserTypeGuard } from '../service/user-type.guard';
import { AddMissionThemeComponent } from './missiontheme/add-mission-theme/add-mission-theme.component';
import { AddMissionSkillComponent } from './missionskill/add-mission-skill/add-mission-skill.component';
import { AddUserComponent } from './user/add-user/add-user.component';
import { UpdateUserComponent } from './user/update-user/update-user.component';


const routes: Routes = [
  // {path:'',component:LoginComponent},
 // {path:'login',component:LoginComponent},
//  {path:'dashboard',component:DashboardComponent,canActivate:[UserTypeGuard],data: {expectedUserType: 'admin'} },
  {path:'dashboard',component:DashboardComponent,data: {expectedUserType: 'admin'} },
  {path:'userPage',component:UserComponent,data: {expectedUserType: 'admin'}},
  {path:'mission',component:MissionComponent,data: {expectedUserType: 'admin'}},
  {path:'addMission',component:AddMissionComponent,data: {expectedUserType: 'admin'}},
  {path:'editMission/:Id',component:UpdateMissionComponent,data: {expectedUserType: 'admin'}},
  {path:'addUser',component:AddUserComponent},
  {path:'editUser/:Id',component:UpdateUserComponent},
  {path:'missionTheme',component:MissionthemeComponent,data: {expectedUserType: 'admin'}},
  {path:'addMissionTheme',component:AddMissionThemeComponent,data: {expectedUserType: 'admin'}},
  {path:'updateMissionTheme/:Id',component:AddMissionThemeComponent,data: {expectedUserType: 'admin'}},
  {path:'missionSkill',component:MissionskillComponent,data: {expectedUserType: 'admin'}},
  {path:'addMissionSkill',component:AddMissionSkillComponent,data: {expectedUserType: 'admin'}},
  {path:'updateMissionSkill/:Id',component:AddMissionSkillComponent,data: {expectedUserType: 'admin'}},
  {path:'missionApplication',component:MissionApplicationComponent,data: {expectedUserType: 'admin'}},
  // {path:'**',component:LoginComponent,data: {expectedUserType: 'admin'}}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AdminSideRoutingModule { }
