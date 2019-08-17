import { Component, OnInit, ViewChild } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { workShopUsersService } from './WorkShopUsersService';
import { Http } from '@angular/http';
import { MatPaginator, MatTableDataSource, MatSort } from '@angular/material';
import { appModuleAnimation } from '@shared/animations/routerTransition';

@Component({
  selector: 'app-work-shop-users',
  templateUrl: './work-shop-users.component.html',
  styleUrls: ['./work-shop-users.component.css'],
  animations: [appModuleAnimation()]
})
export class WorkShopUsersComponent implements OnInit {

 usersLength:number=0;
 SkipCount:number=0;
 MaxResultCount:number=1;
 Sorting:string="name";
  SortingDirec:string="ASC";
  filteringString:string="";
  users: any;
  editedObj:any;
  modalName:string;
  modalAge:any;
  NameSortDirec:string="glyphicon glyphicon-triangle-bottom";
  constructor(private workShopUsersService:workShopUsersService) 
  {
    console.log("construc GetWorkShopUsersLength(")
    this.workShopUsersService.GetWorkShopUsersLength()
                    .subscribe((response:any)=>
                                          {let x=response.json();
                                            console.log(x.result)
                                            this.usersLength=x.result;
                                          }  );
   }
   changeNameSortDirec(c)
   {
     let str=c.getAttribute('class');
     if(str=="glyphicon glyphicon-triangle-bottom")
       {this.NameSortDirec="glyphicon glyphicon-triangle-top";
       this.SortingDirec="DESC";
       this.getdata();
       }
     else
        {this.NameSortDirec="glyphicon glyphicon-triangle-bottom";
        this.SortingDirec="ASC";
       this.getdata();
        }
   }
   FilterBy(filterInput)
   {
     this.filteringString=filterInput.value;
     this.getFilteringdata();



   }
   createUser(formproj)
   {
     console.log("dduy");
     console.log(formproj.value)
     console.log(formproj.value.username)
     console.log(formproj.value.userage)
     console.log(formproj.value.userDpart)
     let obj={
      "name": formproj.value.username,
      "age": formproj.value.userage,
      "departmentId": formproj.value.userDpart
    };
    console.log(obj)
    this.workShopUsersService.createEmployee(obj).subscribe((response:any)=>{console.log(response) });
   }

  ngOnInit() {
   this.getdata();
  }
  DeleteItem(elementIndex:number)
  {
    this.workShopUsersService.DeleteEmployee(elementIndex).subscribe(
      (response:any)=>{console.log(response) }
    );


  }
  ShowForEditModal(_editedObj:any)
  {
    this.editedObj=_editedObj;
    this.modalName=_editedObj.name;
    this.modalAge=_editedObj.age;
    console.log(this.modalName+"  "+this.modalAge+" "+this.editedObj.id)
    


  }
  SaveEditObj()
  {
    console.log(this.modalName+"  "+this.modalAge+" "+this.editedObj.id)
    this.editedObj.name=this.modalName;
    this.editedObj.age=this.modalAge;

    this.workShopUsersService.updateEmployee(this.editedObj).subscribe(
      (response:any)=>{console.log(response) }
    );


  }

  changePageSize(pageSizeUl:any)
  {
    this.SkipCount=0;
    this.MaxResultCount=parseInt(pageSizeUl);
    console.log(pageSizeUl)
    this.getdata();

  }
  previousPage()
  {
    let r=this.SkipCount-this.MaxResultCount;
    if(r>=0)
     {
      this.SkipCount=r;
      this.getdata();
     } 

  }
  nextPage()
  {
    let c=this.SkipCount+this.MaxResultCount;
    if(this.usersLength>c)
    {
      this.SkipCount=c;
      this.getdata();
    }
  
  }
  getdata()
  {
    this.workShopUsersService.GetAllworkShopUsers(this.SkipCount,this.MaxResultCount,this.Sorting,this.SortingDirec).subscribe(
      (response:any)=>{let x=response.json();
        this.users=x.result.items;
          console.log(x.result.items.length)
      }
    );

  }
  getFilteringdata()
  {
    if(this.filteringString)
   { this.workShopUsersService.GetFilteredlworkShopUsers(this.filteringString,this.SkipCount,this.usersLength,this.Sorting,this.SortingDirec)
    .subscribe(
      (response:any)=>{let x=response.json();
        this.users=x.result.items;
          console.log(x.result.items.length)
      } );}

  }
}


