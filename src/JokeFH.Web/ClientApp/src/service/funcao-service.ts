import { Injectable  } from '@angular/core';

@Injectable()
export class FuncaoService {

    isEmptONull(value) {
        return (value === null || value === '');

    }
    delay(ms: number) {
        return new Promise(resolve => setTimeout(resolve, ms));
    }
}