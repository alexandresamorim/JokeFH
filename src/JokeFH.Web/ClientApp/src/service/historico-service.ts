import { Component, Inject } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import {HistoricoModel } from "../model/historico-model"


export class HistoricoService {

    private baseUrl: any;

    constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this.baseUrl = baseUrl;
    }

    getHistoricoPorJogdor(jogador) {
        return this.http.get<HistoricoModel[]>(this.baseUrl + `api/Historico/ObterJogosPorJogador/${jogador}`);
    }

    setHistorico(historico) {
        return this.http.post(this.baseUrl + 'api/Historico/Adicionar', historico);
    }

}