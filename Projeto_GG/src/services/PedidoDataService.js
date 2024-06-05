import http from "../http-common";

class PedidoDataService {
    getAll() {
        return http.get("/Pedido");
    }

    create(data) {
        return http.post("/Pedido", data)
    }
}

export default new  PedidoDataService();