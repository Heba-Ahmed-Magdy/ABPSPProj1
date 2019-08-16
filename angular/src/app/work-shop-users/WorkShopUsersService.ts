import { Injectable } from "@angular/core";
import { Http } from '@angular/http';
import { SortAndpagedobj } from "./sortAndpagedobj";


@Injectable()
export class workShopUsersService 
{
    SkipCount:number;
    MaxResultCount:Number;
    Sorting:string;
    SortingDirec:string;
    FilteringString:string;

    constructor(private http:Http){}
    //sortAndpagedobj:SortAndpagedobj
    GetAllworkShopUsers(_SkipCount,_MaxResultCount,_Sorting,_SortingDirec)
    {
        this.SkipCount=_SkipCount;
        this.MaxResultCount=_MaxResultCount;
        this.Sorting=_Sorting;
        this.SortingDirec=_SortingDirec;
        console.log("insidemy httpreq");
        //http://localhost:21021/api/services/app/Employee/GetAll?SkipCount=1&MaxResultCount=1&Sorting=name%20ASC
      
        let x=this.http.get('http://localhost:21021/api/services/app/Employee/GetAll?SkipCount='
              +this.SkipCount+'&MaxResultCount='+this.MaxResultCount+'&Sorting='+this.Sorting+'%20'+this.SortingDirec);
        console.log(x);
        return x;
    }

    GetFilteredlworkShopUsers(_FilteringString,_SkipCount,_MaxResultCount,_Sorting,_SortingDirec)
    {
        this.SkipCount=_SkipCount;
        this.MaxResultCount=_MaxResultCount;
        this.Sorting=_Sorting;
        this.SortingDirec=_SortingDirec;
        this.FilteringString=_FilteringString;

        console.log("insidemy GetFilteredlworkShopUsers");
        //http://localhost:21021/api/services/app/Employee/GetAllFilteredAsync?FilteringString=H&Sorting=name%20Asc&SkipCount=0&MaxResultCount=2
      
        let x=this.http.get('http://localhost:21021/api/services/app/Employee/GetAllFilteredAsync?FilteringString='+
        this.FilteringString+'&Sorting='+this.Sorting+'%20'+this.SortingDirec+'&SkipCount='
              +this.SkipCount+'&MaxResultCount='+this.MaxResultCount);
        console.log(x);
        return x;
    }
    DeleteEmployee(employindex:any)
    {
        let x=this.http.delete("http://localhost:21021/api/services/app/Employee/Delete?Id="+employindex);
        console.log(x);
        return x;

    }
    updateEmployee(empObj:any)
    {
        let x=this.http.put('http://localhost:21021/api/services/app/Employee/Update',empObj);
        console.log(x);
        return x;
    }
    GetWorkShopUsersLength()
    {
        let count=this.http.get('http://localhost:21021/api/services/app/Employee/GetEmployeesLength');
        console.log(count)
        return count;

    }
    createEmployee(empobj)
    {
       let obj= this.http.post('http://localhost:21021/api/services/app/Employee/Create',empobj);
       
       return obj;

    }


}