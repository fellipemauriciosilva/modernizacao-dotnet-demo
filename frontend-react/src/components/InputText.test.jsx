import { render, screen, fireEvent } from '@testing-library/react';
import { InputText } from './InputText';

test('deve exibir valor inicial e reagir a mudança', () => {
  const handleChange = jest.fn();
  render(<InputText label="Nome" value="teste" name="nome" onChange={handleChange} />);
  fireEvent.change(screen.getByDisplayValue('teste'), { target: { value: 'novo' } });
  expect(handleChange).toHaveBeenCalled();
});
