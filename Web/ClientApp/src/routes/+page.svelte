<script>
	import welcome from "$lib/images/prowitechlogo.jpg";
	import welcome_fallback from "$lib/images/prowitechlogo.jpg";

	let login = '';
	let pwd = '';
</script>

<main>
	<section>
		<h1>
			<span class="welcome">
				<picture>
					<source srcset={welcome} type="image/webp" />
					<img src={welcome_fallback} alt="Welcome" />
				</picture>
			</span>

			<div id="panel">
				<form>
					<label for="username">Nazwa użytkownika:</label>
					<input
						type="text"
						placeholder="Podaj nazwę użytkownika"
						id="username"
						required
						bind:value={login}
					/>
					<label for="password">Hasło:</label>
					<input
						type="password"
						placeholder="Podaj hasło"
						id="password"
						required
						bind:value={pwd}
					/>
					<div id="lower">
						<input type="submit" value="Loguj!" />
					</div>
				</form>
			</div>
		</h1>
	</section>
</main>

<style>
	section {
		display: flex;
		flex-direction: column;
		justify-content: center;
		align-items: center;
		flex: 0.6;
	}

	h1 {
		width: 100%;
	}

	.welcome {
		display: block;
		position: relative;
		width: 50%;
		height: 0;
		margin: auto;
		padding: 0 0 calc(100% * 495 / 2048) 0;
	}

	.welcome img {
		position: absolute;
		width: 50%;
		height: 100%;
		top: 0;
		margin: 0 auto;
		padding-left: 15%;
		display: block;
	}

	#panel {
		width: 75%;
		margin: 0 auto;
		padding: 15px 0 0;
		background: #fff;
		border: 1px solid silver;
		font: 16px calibri;
		letter-spacing: -1px;
		-webkit-box-shadow: 0 0 2px silver;
		-moz-box-shadow: 0 0 2px silver;
		box-shadow: 0 0 2px silver;
	}
	form {
		margin: 0;
	}

	label {
		display: block;
		width: 50%;
		padding: 10px 10px;
		margin: 0 20%;
		text-align: left;
		color: #696969;
		font-size: 16px;
		text-shadow: 0 0 1px silver;
	}

	#username,
	#password {
		display: block;
		width: 50%;
		margin: 0 20%;
		padding: 10px 5px;
		border: 1px solid silver;
		outline: 5px solid #ebebeb;
		font-size: 22px;
	}

	#username:focus,
	#password:focus {
		outline: 5px solid #e5f2f8;
	}

	#lower {
		background: #ecf2f5;
		width: 96%;
		padding: 1% 2%;
		margin-top: 20px;
	}

	input[type="submit"] {
		width: 70px;
		padding: 5px 13px;
		border: 1px solid #005f85;
		color: white;
		text-shadow: 0 0 1px black;
		background: #98c9dc;
		position: relative;
		left: 40%;
	}
</style>
