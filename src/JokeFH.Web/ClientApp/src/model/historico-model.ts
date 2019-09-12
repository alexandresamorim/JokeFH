import { UUID } from 'angular2-uuid';

export class HistoricoModel {
    id: string;
    jogador: string;
    dataHora: string;
    vencedor: string;

    constructor(jogador, vencedor) {
        this.id = UUID.UUID();
        this.jogador = jogador;
        this.vencedor = vencedor;
        this.dataHora = new Date().toISOString().slice(0, 16);
    }
}