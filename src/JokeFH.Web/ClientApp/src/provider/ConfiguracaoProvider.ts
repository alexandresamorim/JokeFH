import { Injectable } from '@angular/core';
import {HistoricoModel } from "../model/historico-model";
@Injectable()
export class ConfiguracaoProvider {
    jogador: any;
    partidaFinal: any;

    constructor() {
        this.partidaFinal = 10;
    }
    
}