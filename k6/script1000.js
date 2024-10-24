mport http from 'k6/http';
import { check, sleep } from 'k6';

// Configuração de carga
export const options = {
    stages: [
        { duration: '30s', target: 1000 }, // Sobe até 1000 usuários simultâneos
        { duration: '1m', target: 50 },  // Aumenta para 50 usuários
        { duration: '30s', target: 0 },  // Reduz carga
    ],
};

export default function () {
    // Simulação de cadastro
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

    // Verificação do status da resposta
    check(response, {
        'status é 200': (r) => r.status === 200,
        'resposta contém id': (r) => JSON.parse(r.body).id !== undefined,
    });

    sleep(1); // Espera 1 segundo antes de outra iteração
}