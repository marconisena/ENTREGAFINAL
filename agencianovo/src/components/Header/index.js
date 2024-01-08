import Link from 'next/link'

export default function Header() {
	return (
		<header className="header">
			<img src="./imagem/logo.png" alt="logo.png" />
			<ul>
				<li>
					<Link href="/usuario">Lista de Usuario 1</Link>
				</li>
				<li>
					<Link href="/usuario2">Lista  de Usuario 2</Link>
				</li>
				
			</ul>
		</header>
	)
}