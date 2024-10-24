mport http from 'k6/http';
import { check, sleep } from 'k6';

// Configura��o de carga
export const options = {
    stages: [
        { duration: '30s', target: 1000 }, // Sobe at� 1000 usu�rios simult�neos
        { duration: '1m', target: 50 },  // Aumenta para 50 usu�rios
        { duration: '30s', target: 0 },  // Reduz carga
    ],
};

export default function () {
    // Simula��o de cadastro
    const url = 'https://seu-sistema.com/api/cadastrar';
    const payload = JSON.stringify({
        nome: 'Cliente Teste',
        email: 'cliente_teste@exemplo.com',
        telefone: '99999-9999',
    });

    const params = {
        headers: {
            'Content-Type': 'application/json',
        },
    };

    const response = http.post(url, payload, params);

    // Verifica��o do status da resposta
    check(response, {
        'status � 200': (r) => r.status === 200,
        'resposta cont�m id': (r) => JSON.parse(r.body).id !== undefined,
    });

    sleep(1); // Espera 1 segundo antes de outra itera��o
}