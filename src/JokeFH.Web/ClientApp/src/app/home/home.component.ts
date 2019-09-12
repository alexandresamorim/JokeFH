import { Component } from '@angular/core';
import { ConfiguracaoProvider } from "../../provider/ConfiguracaoProvider";
import { HistoricoModel } from "../../model/historico-model";
import { HistoricoService } from '../../service/historico-service';
import { Cartas } from "../../model/carta-enum";
import { FuncaoService } from '../../service/funcao-service';

@Component({
    selector: 'app-home',
    templateUrl: './home.component.html',
})
export class HomeComponent {
    computador: any = "Computador";
    empate: any = "Empate";
    jogador: any;
    patidas: any = 0;
    partidaFinal: any = 10;
    pontuacaoJogador: any = 0;
    pontuacaoComputador: any = 0;
    cartaJogador: any = "";
    cartaComputador: any = "";
    vencedorPartida: any = "";
    vencedorJogo: any = "";
    resultadosJogo: any[] = [];

    constructor(public config: ConfiguracaoProvider,
        private historicoService: HistoricoService,
        private funcoes: FuncaoService ) {
        this.jogador = config.jogador;
        this.partidaFinal = config.partidaFinal;
    }

    getResultado(cartaId) {
        this.patidas++;

        this.cartaJogador = Cartas[cartaId];

        this.funcoes.delay(3000);

        var aleatorio = Math.floor(Math.random() * 3) + 1;
        this.cartaComputador = Cartas[aleatorio];

        if (this.cartaJogador === this.cartaComputador)
            this.vencedorPartida = this.empate;
        else {
            switch (this.cartaJogador) {
                case "Pedra":
                    {
                        if (this.cartaComputador === "Tesoura") {
                            this.vencedorPartida = this.jogador;
                            this.pontuacaoJogador++;
                        } else {
                            this.vencedorPartida = this.computador;
                            this.pontuacaoComputador++;
                        }
                        break;
                    }

                case "Papel":
                    {
                        if (this.cartaComputador === "Pedra") {
                            this.vencedorPartida = this.jogador;
                            this.pontuacaoJogador++;
                        } else {
                            this.vencedorPartida = this.computador;
                            this.pontuacaoComputador++;
                        }
                        break;
                    }

                case "Tesoura":
                    {
                        if (this.cartaComputador === "Papel") {
                            this.vencedorPartida = this.jogador;
                            this.pontuacaoJogador++;
                        } else {
                            this.vencedorPartida = this.computador;
                            this.pontuacaoComputador++;
                        }
                        break;
                    }
            }
        }

        this.resultadosJogo.push({
            Jogador: this.jogador,
            CartaJogador: this.cartaJogador,
            Computador: this.computador,
            CartaComputador: this.cartaComputador,
            Vencedor: this.vencedorPartida
        });
        console.log(this.resultadosJogo);

        if (this.patidas === this.partidaFinal) {

            this.vencedorJogo = this.pontuacaoJogador > this.pontuacaoComputador ? this.jogador
                : this.pontuacaoJogador == this.pontuacaoComputador ? this.empate : this.computador;
            if (this.vencedorJogo == this.computador)
                alert(`Não foi dessa vez ${this.jogador}! Para jogar novamente, Clique em Iniciar\Reiniciar.`);
            else if (this.vencedorJogo == this.empate)
                alert(`Você foi muito bem, mesmo dando ${this.empate}`);
            else
                alert(`Parabéns ${this.jogador} você venceu o desafio`);

            let historico = new HistoricoModel(this.jogador, this.vencedorJogo);
            //this.config.historicos.push(historico);
            this.historicoService.setHistorico(historico).subscribe();
        }


    }

    reiniciarJogo() {
        this.vencedorJogo = "";
        this.vencedorPartida = "";
        this.pontuacaoJogador = 0;
        this.pontuacaoComputador = 0;
        this.patidas = 0;
        this.cartaComputador = "";
        this.cartaJogador = "";
        this.resultadosJogo = [];
    }
}
