import { Component } from '@angular/core';
import { ConfiguracaoProvider } from '../provider/ConfiguracaoProvider';
import { FuncaoService } from '../service/funcao-service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
    title = 'JokeFH';

    constructor(private config: ConfiguracaoProvider, private funcao: FuncaoService) {

        let jogardor = prompt("Olá jogador, por favor digite aqui seu nome!");

        this.config.jogador = this.funcao.isEmptONull(jogardor) ? "Anônimo" : jogardor;
    }
}
