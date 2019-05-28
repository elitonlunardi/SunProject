export class CityViewModel {
    public id : string
    public name: string;
    public creationDate: Date;

    constructor(name: string) {
        this.name = name;
    }
}