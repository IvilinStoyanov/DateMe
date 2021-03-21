import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MemberEditRoutingModule } from './member-edit.routing';
import { SharedModule } from 'src/app/modules/shared/shared.module';
import { MemberEditComponent } from './member-edit.component';
import { PhotoEditComponent } from './components/photo-edit/photo-edit.component';
import { FileUploadModule } from 'ng2-file-upload';

@NgModule({
  imports: [
    CommonModule,
    MemberEditRoutingModule,
    SharedModule,
    FileUploadModule
  ],
  declarations: [MemberEditComponent, PhotoEditComponent]
})
export class MemberEditModule { }
