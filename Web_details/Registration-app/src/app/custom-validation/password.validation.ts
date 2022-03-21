import { AbstractControl,  ValidatorFn } from "@angular/forms"


export function passwordValidator({ minlength, maxlength }: { minlength: number; maxlength: number; }): ValidatorFn {

     
 function passwordvalidatorlogic (control: AbstractControl): ValidationErrors | null {
        const pwd: string = <string>control.value;
         

        if (pwd.length < minlength)
            return {
                minlengtherror: {
                    expectedlength: minlength,
                    currentlength: pwd.length
                }
            }

        if (pwd.length > maxlength)
            return {
                maxlengtherror: {
                    expectedlength: maxlength,
                    currentlength: `${pwd.length}`
                }
            }

        

        let digitExists = false

        for (let i = 0; i < pwd.length; i++) {
            if (pwd[i] >= '0' && pwd[i] <= '9') {
                digitExists = true
                break;
            }
        }
        
         

         
        if (!maxlength)    
        return {  maxlength: '10  maxlength should be present in the password'} 

        if (!minlength)    
             return {  minlength: '5 minlength should be present in the password'}

        if (!digitExists)
            return { digit: '1 digit should be present in the password' }

         
    }

    return passwordvalidatorlogic
}