import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ConfiguracaoProvider } from "../../provider/ConfiguracaoProvider";
import { HistoricoModel } from '../../model/historico-model';
import { HistoricoService } from '../../service/historico-service';

@Component({
    selector: 'app-historico-data',
    templateUrl: './historico-data.component.html'
})
export class HistoricoDataComponent {

    historicos: HistoricoModel[];

    constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string,
        public config: ConfiguracaoProvider,
        private historicoService: HistoricoService) {
     
        let jogador = this.config.jogador;

        historicoService.getHistoricoPorJogdor(jogador).subscribe(result => {
            this.historicos = result;
        }, error => console.error(error));
  }
}
