import { Injectable } from "@angular/core";
import { HttpClient } from '@angular/common/http';
import { Observable } from "rxjs";
import { CityViewModel } from "../models/CityModel";

@Injectable()
export class CidadeService {

    private api: string = "https://localhost:44310/api";
    private addCidade: string = "/City/AddCity";
    private listCidades: string = "/City/GetAllCities";
    private getTemperaturaPorIdCidade: string = "/City/GetWeathersByCityId"

    constructor(private http: HttpClient) { }

    adicionarCidade(nomeCidade: string) {
        var city = new CityViewModel(nomeCidade);
        return this.http.post(`${this.api}${this.addCidade}`, city);
    }

    listarCidades(): Observable<CityModel> {
        return this.http.get<CityModel>(`${this.api}${this.listCidades}`);
    }

    obterTemperaturaPorIdCidade(id: string): Observable<WeatherModel[]> {
        console.log(id);
        return this.http.get<WeatherModel[]>(`${this.api}/City/GetWeathersByCityId?id=${id}`)
    }

}

export class CityModel {
    id: string
    name: string
}

export class WeatherModel {
    id: string
    date: Date
    media: number
}

